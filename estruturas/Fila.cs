using System;

namespace estruturas
{
    public class Fila
    {
        Posicao primeiro, ultimo;

        public void push(object item){

            if(primeiro == null){
                ultimo = new Posicao(null, null, item);
                primeiro = ultimo;
            } else{
                primeiro = new Posicao(null, primeiro, item);
                primeiro.proximo.anterior = primeiro;
            }
            
        }

        public object pull(){
            if(primeiro == null){
                throw new InvalidOperationException("fila vazia");
            }

            object resultado = ultimo.item;

            if(ultimo.anterior != null){
                ultimo = ultimo.anterior;
            }

            return resultado;
        }

        class Posicao{
            public Posicao proximo;
            public Posicao anterior;
            public object item;

            public Posicao(Posicao anterior, Posicao proximo, object item){
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}