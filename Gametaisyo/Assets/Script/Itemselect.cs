using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Itemselect : MonoBehaviour
{
    [SerializeField]
    private Sprite MikakuSprite;
    [SerializeField]
    private Sprite TyoukakuSprite;
    [SerializeField]
    private Sprite KyuukakuSprite;
    [SerializeField]
    private Sprite SikakuSprite;
    [SerializeField]
    private Sprite ShokkakuSprite;
    /*
  * 五感スプライトを表示する用のゲームオブジェクト(UI->Image)
  */
    [SerializeField]
    private GameObject[] senses = new GameObject[5];

    /*
     * 表示する用のオブジェクト(UI->Image)のImageを設定する変数
     */
    private Image[] sensesImage = new Image[5];

    /*
    * 表示する用のオブジェクト(UI->Image)の位置・スケールを設定する変数
    * UIなので、RectTransformを使用
    */
    private RectTransform[] sensesRect = new RectTransform[5];
    /*
    * 武器選択UIの真ん中に表示している武器画像の座標
    */
    private Vector2 Main = new Vector2(0, -188f);
    /*
    * 0 : 武器画像を透明にする基準座標
    * 1 : 武器画像を逆の端に移動する基準座標
    */
    private Vector2 Right0 = new Vector2(81f, -188f);
    private Vector2 Right1 = new Vector2(162f, -188f);
    private Vector2 Left0 = new Vector2(-81f, -188f);
    private Vector2 Left1 = new Vector2(-162f, -188f);
    /*
     * 武器画像をスライド(装備変更)させた後の座標(目的地の座標)
     */
    private Vector2[] Target = new Vector2[7];
    /*
    * スライド(装備変更)する前の座標(現在の座標)
    */
    private Vector2[] sensesRectPos = new Vector2[7];
    /*
    * スライド(装備変更)をするかのフラグ
    */
    private bool SlideFlag;
    /*
     * スライド(装備変更)する前の座標(現在の座標)を保存するためのフラグ
     * 現在の座標を保存するためには、スライドするためのループ処理の一回目だけ座標を保存する処理をする必要がある
     */
    private bool PosFlag = true;
    /*
    * スライドする方向
    *      0 : 左方向
    *      1 : 右方向
    */
    private int Dir = 0;
    /*
    * 現在装備している武器の種類
    *      0 : 視覚　
    *      1 : 聴覚
    *      2 : 味覚
    *      3 : 嗅覚
    *      4 : 触覚
    */
    public int sensesType { private set; get; }

    public void Senses()
    {
        for (int i = 0; i < senses.Length; i++)
        {
            sensesImage[i] = senses[i].GetComponent<Image>();
            sensesRect[i] = senses[i].GetComponent<RectTransform>();
            /*
             * 五感画像が初期状態からバラバラになっている可能性があるので、左から右に武器画像0～4を整列させる
             */
            sensesRect[i].localPosition = new Vector2(-108f + i * 54, -188f);
            /*
             * 真ん中以外の武器画像のサイズを 1/1.8 にする
             */
            if (i == 2)
            {
                sensesRect[i].localScale = new Vector3(1, 1, 1);
            }
            else
            {
                sensesRect[i].localScale = new Vector3(1 / 1.8f, 1 / 1.8f, 1 / 1.8f);
            }
 
            switch (i)
            {
                case 1:
                    sensesImage[i].sprite = SikakuSprite;
                    break;
                case 2:
                    sensesImage[i].sprite = TyoukakuSprite;
                    break;
                case 3:
                    sensesImage[i].sprite = MikakuSprite;
                    break;
                case 4:
                    sensesImage[i].sprite = KyuukakuSprite;
                    break;
                case 5:
                    sensesImage[i].sprite = ShokkakuSprite;
                    break;
                case 6:
                    sensesImage[0].sprite = sensesImage[5].sprite;
                    sensesImage[i].sprite = sensesImage[(i + 5) % 8].sprite;
                    //Debug.Log(i);
                    //Debug.Log((i + 3) % 6);
                    break;
            }

            /*
             * 両端の武器画像を透明、真ん中3つの画像はそのまま
             */
            if (i == 0 || i == 4) sensesImage[i].color = new Color(255, 255, 255, 0);
            else sensesImage[i].color = new Color(255, 255, 255, 255);
        }
    }
    public void SlideItem()
    {
        if (SlideFlag)
        {
            /*
             * 武器画像の数(5個)全てをスライドさせる
             */
            for (int i = 0; i < senses.Length; i++)
            {
                if (PosFlag)
                {
                    sensesRectPos[i] = sensesRect[i].localPosition;
                }
                //Debug.Log(WeponRectPos[0]);
                /*
                 * 左にスライドさせる場合
                 */
                if (Dir == 0)
                {
                    /*
                     * スライド後(目的地)の座標を指定
                     */
                    Target[i] = new Vector2(sensesRectPos[i].x - 54f, sensesRectPos[i].y);
                    /*
                     * 武器画像を目的地に移動させる
                     * 移動座標がRight0を超えたら武器画像を透明から元に戻す
                     * 移動座標がLeft0を超えたら武器画像を透明にする
                     * 移動座標がLeft1(左端)になったら右端に瞬間移動させる
                     */
                    sensesRect[i].localPosition = Vector2.MoveTowards(sensesRect[i].localPosition, Target[i], Time.deltaTime * 200);
                    if (sensesRect[i].localPosition.x <= Right0.x)
                    {
                        sensesImage[i].color = new Color(255, 255, 255, 255);
                    }
                    if (sensesRect[i].localPosition.x <= Left0.x)
                    {
                        sensesImage[i].color = new Color(255, 255, 255, 0);
                    }
                    if (sensesRect[i].localPosition.x == Left1.x)
                    {
                        sensesRect[i].localPosition = new Vector2(Right1.x - 54f, Right1.y);
                    }
                    /*
                     * 左にスライドさせる場合
                     */
                }
                else
                {
                    /*
                     * スライド後(目的地)の座標を指定
                     */
                    Target[i] = new Vector2(sensesRectPos[i].x + 54f, sensesRectPos[i].y);
                    /*
                     * 武器画像を目的地に移動させる
                     * 移動座標がLeft0を超えたら武器画像を透明から元に戻す
                     * 移動座標がRight0を超えたら武器画像を透明にする
                     * 移動座標がRight1(右端)になったら左端に瞬間移動させる
                     */
                    sensesRect[i].localPosition = Vector2.MoveTowards(sensesRect[i].localPosition, Target[i], Time.deltaTime * 200);
                    if (sensesRect[i].localPosition.x >= Left0.x)
                    {
                        sensesImage[i].color = new Color(255, 255, 255, 255);
                    }
                    if (sensesRect[i].localPosition.x >= Right0.x)
                    {
                        sensesImage[i].color = new Color(255, 255, 255, 0);
                    }

                    if (sensesRect[i].localPosition.x == Right1.x)
                    {
                        sensesRect[i].localPosition = new Vector2(Left1.x + 54f, Left1.y);
                    }
                }
                /*
                 * 武器画像が目的地まで移動できたらスライドを終了する
                 */
                if (sensesRect[i].localPosition.x == Target[i].x)
                {
                    SlideFlag = false;
                }

                /*
                 * 武器画像のどれかが真ん中の座標に移動した場合
                 */
                if (sensesRect[i].localPosition.x == Main.x)
                {
                    /*
                     *  ナイフ     :  WeponTypeを0にする
                     *  ハンドガン :  WeponTypeを1にする
                     *  フライパン :  WeponTypeを2にする
                     */
                    if (sensesImage[i].sprite == SikakuSprite)
                    {
                        sensesType = 0;
                    }
                    else if (sensesImage[i].sprite == TyoukakuSprite)
                    {
                        sensesType = 1;
                    }
                    else if(sensesImage[i].sprite == MikakuSprite)
                    {
                        sensesType = 2;
                    }
                    else if (sensesImage[i].sprite == KyuukakuSprite)
                    {
                        sensesType = 3;
                    }
                    else
                    {
                        sensesType = 4;
                    }
                        /*
                         * 武器画像の大きさを1にする(他は1/1.8)
                         */
                        sensesRect[i].localScale = new Vector3(1, 1, 1);

                    /*
                     * 真ん中以外の武器画像のサイズを 1/1.8 にする
                     */
                }
                else
                {
                    sensesRect[i].localScale = new Vector3(1 / 1.8f, 1 / 1.8f, 1 / 1.8f);
                }
            }
            PosFlag = false;
        }
    }

    // Use this for initialization
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        /*
         * こちらもデバッグ用で
         *      Gキー : UIを左にスライド
         *      Hキー : UIを右にスライド
         */
        if (Input.GetKeyDown(KeyCode.G) && !SlideFlag)
        {
            SlideFlag = true;
            PosFlag = true;
            Dir = 0;
        }
        if (Input.GetKeyDown(KeyCode.H) && !SlideFlag)
        {
            SlideFlag = true;
            PosFlag = true;
            Dir = 1;
        }

        SlideItem();
    }


  }
