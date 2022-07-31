
using CSiAPIv1;                 
using System;
using static Globals;

namespace ETABSPluginBoilerPlate
{
    
    public class cPlugin
    {

        public void Main(ref cSapModel _SapModel, ref cPluginCallback _ISapPlugin)
        {
            ParentPluginObject = this;
            SapModel = _SapModel;
            ISapPlugin = _ISapPlugin;

            try
            {
                // your code here
            }
            catch (Exception ex)
            {
                try
                {
                    ISapPlugin.Finish(1);
                    Console.WriteLine(ex);
                }
                catch (Exception ex1)
                {
                    Console.WriteLine(ex1);
                    throw;
                }
            }
        }

        
        public int Info(ref string txt)
        {
            try
            {
                txt = "Author: Syed Haseeb Shah";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }

            return 0;
        }

        
        ~cPlugin()
        {
            Console.WriteLine(GC.GetGeneration(0));
        }
    }
}
