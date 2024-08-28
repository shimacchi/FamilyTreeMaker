using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FamilyTreeMaker
{
    internal class PersonLabel : Label
    {
        //ラベルコントロールにオリジナル要素としてPersonクラスオブジェクトを格納
        Person person;
        //マウスドラッグでの移動に関連するプロパティ
        public Boolean isMoveable;
        public int pX, pY;

        public PersonLabel(Person person)
        {
            this.person = person;
            this.isMoveable = false;
        }
    }
}
