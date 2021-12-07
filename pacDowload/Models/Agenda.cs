using System.Collections.Generic;

namespace aula3UC05.Models
{
    public class Agenda
    {
        private static List<ItemAgenda> lista  = new List<ItemAgenda>();

        public static void Incluir(ItemAgenda item){
            lista.Add(item);
        }
        public static List<ItemAgenda> Listar(){
            return lista;
        }
    }
}