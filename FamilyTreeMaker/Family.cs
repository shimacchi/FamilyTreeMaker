using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeMaker
{
    //家族構成を格納するクラス
    internal class Family
    {
       List<Person> list;

        public Family()
        {
            list = new List<Person>();
        }

        public void Add(Person person)
        {
            list.Add(person);
        }
        public void Remove(Person person)
        {
            list.Remove(person);
        }

        //対象のidをもつ人物を返す
        public Person GetFromId(int id)
        {
            foreach (Person person in list)
            {
                if (person.getId() == id) return person;
            }

            return null;
        }

        //対象人物の子供の数を返す
        public int GetChildNum(Person p)
        {
            int ret = 0;
            //配偶者のid
            int id = p.getId();
            int sid = p.getSpouseID();

            if (sid == -1)
            {
                sid = -2;
            }

            foreach (Person person in list)
            {
                if (person.getParentID() == id || person.getParentID() == sid) ret++;
            }

            return ret;
        }
    }
}
