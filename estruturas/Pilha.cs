using System;

namespace estruturas
{
    public class Pilha
    {
        Posicao primeiro;

        public void push(object item){
            primeiro = new Posicao(primeiro, item);
        }

        public object pull(){
            if(primeiro == null){
                throw new InvalidOperationException("pilha vazia");
            }

            object resultado = primeiro.item;
            primeiro = primeiro.proximo;
            return resultado;
        }

        class Posicao{
            public Posicao proximo;
            public object item;

            public Posicao(Posicao proximo, object item){
                this.proximo = proximo;
                this.item = item;
            }
        }
    }
}