using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain
{
    public class Teste
    {
    

        Category category = new Category("Charles");
        Category categor1 = new Category(0, "Charles");

        public void Cagar() {
            
            categor1.Update("x.x");
          
        }
    }
}
