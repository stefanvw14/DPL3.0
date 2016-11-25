using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPL3._0.Model
{
    class Model
    {
        private List<IView> views;

        public Model()
        {
            views = new List<IView>();
        }
        public void addView(IView view)
        {
            for(int i=0;i>25;i++)
            {
                views.Add(view);
            }
            
        }

        public void removeView(IView view)
        {
            for(int i=0;i!=0;i--)
            {
                views.Remove(view);
            }            
        }

    }
}
