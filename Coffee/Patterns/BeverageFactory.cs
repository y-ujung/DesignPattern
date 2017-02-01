using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class BeverageFactory
    {
        public enum BEVERAGE_TYPE { ESPRESSO, DRAKROAST }
        public enum CONDIMENT_TYPE { WHIP, MOCHA, SOY }

        #region Singleton
        private static BeverageFactory FInstance = new BeverageFactory();

        private BeverageFactory()
        {

        }

        public static BeverageFactory INSTANCE
        {
            get
            {
                return FInstance;
            }
        } 
        #endregion

        public Beverage MakeBeverage(BEVERAGE_TYPE bt, List<CONDIMENT_TYPE> clist)
        {
            switch (bt)
            {

                case BEVERAGE_TYPE.ESPRESSO:
                    {
                        Beverage item = new Espresso();
                        item = ApplyCondiment(clist, item);
                        return item;
                    }

                case BEVERAGE_TYPE.DRAKROAST:
                    {
                        Beverage item = new DarkRoast();
                        item = ApplyCondiment(clist, item);
                        return item;
                    }

                default:
                    return null;

            }

        }

        private static Beverage ApplyCondiment(List<CONDIMENT_TYPE> clist, Beverage item)
        {
            foreach (var c in clist)
            {
                switch (c)
                {
                    case CONDIMENT_TYPE.WHIP:
                        {
                            item = new Whip(item);
                        }
                        break;
                    case CONDIMENT_TYPE.MOCHA:
                        {
                            item = new Mocha(item);
                        }
                        break;
                    case CONDIMENT_TYPE.SOY:
                        {
                            item = new Soy(item);
                        }
                        break;
                }
            }

            return item;
        }
    }
}
