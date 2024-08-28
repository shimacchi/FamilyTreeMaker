using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeMaker
{
    /// <summary>
    /// オブジェクト間の関係など実際にグラフィックを扱うクラス
    /// </summary>
    internal class DrawFamilyGraphics
    {
        //描画対照たる共通のグラフィックスコンテキスト
        static Graphics g;

        public static void setGrahicContext(Graphics gc)
        {
            g = gc;
        }
    }
}
