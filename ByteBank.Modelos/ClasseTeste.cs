using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Modelos
{
    class ClasseTeste
    {
        public ClasseTeste()
        {
            ModificadoresTeste teste = new ModificadoresTeste();
            teste.MetodoPublico();
            teste.MetodoInterno();
        }

    }

    class ClasseDerivada : ModificadoresTeste
    { 
        public ClasseDerivada()
        {
            MetodoProtegio();
        }
    
    }


    public class ModificadoresTeste
    {
        public void MetodoPublico()
        {

        }

        private void MetodoPrivado()
        {

        }

        protected void MetodoProtegio()
        {

        }

        internal void MetodoInterno()
        {
            // Visivel apenas para o projeto ByteBank.Modelos ! 
        }
    }

    
}
