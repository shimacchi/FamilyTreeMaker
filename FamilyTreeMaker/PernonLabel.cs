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
   
        public PersonLabel(Person person)
        {
            this.person = person;
        }
    }
}
