using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FamilyTreeMaker
{
    /// <summary>
    /// 人物のクラス
    /// </summary>
    internal class Person
    {
        //共通で管理するID番号(=ソフト起動時から追加した人数)
        static int PresentID = 0;
        //内部的に識別するID
        int id;
        //氏名
        string name;
        //死亡しているか否か
        Boolean isDead;
        //死亡時年齢
        int ageOfDeath;
        //発端者か否か
        Boolean isProband;
        //罹患者か否か
        Boolean isSuffered;

        //性(0: 男性, 1: 女性, 2:判別不能)
        int sex;

        //結婚しているか
        Boolean isMarriged;
        //近親婚か否か
        Boolean isConsanguineous;

        //世代
        int generation;

        //親を表す対象を格納するid
        int parentID;
        //配偶者を表すid
        int spouseID;


        public Person(int sex)
        {
            //性の情報は最低限必要
            this.sex = sex;
            id = ++PresentID;
            parentID = -1;
        }

        public Person()
        {
            //デフォルトでは男性で
            this.sex = 0;
            id = ++PresentID;
            parentID = -1;
        }

        public int getParentID()
        {
            return parentID;
        }
        public void setParentID(int parentID)
        {
            this.parentID = parentID;
        }

        public int getSpouseID()
        {
            return spouseID;
        }

        public void setSpouseID(int spouseID)
        {
            this.spouseID = spouseID;
        }

        public int getId()
        {
            return id;
        }
        public void setId(int id)
        {
            this.id = id;
        }

        public int getSex()
        {
            return sex;
        }
        public void setSex(int sex)
        {
            this.sex = sex;
        }

        public Boolean getIsDead()
        {
            return isDead;
        }

        public void setIsDead(Boolean isDead)
        {
            this.isDead = isDead;
        }

        public string getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }

        public int getAgeOfDeath()
        {
            return ageOfDeath;
        }

        public void setAgeOfDeath(int age)
        {
            this.ageOfDeath = age;
        }

        public Boolean getIsProband()
        {
            return isProband;
        }

        public void setIsProband(Boolean isProband)
        {
            this.isProband = isProband;
        }

        public Boolean getIsSuffered()
        {
            return isSuffered;
        }

        public void setIsSuffered(Boolean isSuffered)
        {
            this.isSuffered = isSuffered;
        }

        public Boolean getIsConsanguineous()
        {
            return isConsanguineous;
        }

        public void setIsConsanguineous(Boolean isConsanguineous)
        {
            this.isConsanguineous = isConsanguineous;
        }
    }
}
