using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FamilyTreeMaker
{
    /// <summary>
    /// 人物のクラス
    /// </summary>
    internal class Person
    {
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

        //性
        private enum Sex
        {
            male, female, unknown
        }

        //結婚しているか
        Boolean isMarriged;
        //近親婚か否か
        Boolean isConsanguineous;

        //世代
        int generation;

    }
}
