//Autora: Giovanna Gonçalves Cutieri

//Portugol Studio
//versão web

//introduçao ao portugol
//calcular media aritmetica

programa {
    
    inclua biblioteca Util --> u
    
	funcao inicio() {
		escreva("hello world\n")
		
		inteiro i = 0, j = 0, menu = 0, sair = 0
		real soma = 0, media = 0, notas[10]
		cadeia aluno
		
		
		escreva("\n\ndigite o nome do aluno: ")
		leia(aluno)
		
		enquanto(sair==0){
		    escreva("\n1-adicionar nota  2-seguir\n")
		    
		    leia(menu)
		    escolha(menu){
		        caso 1: 
		            //adicionar mais uma nota
		            escreva("digite a nota " + i + ": ")
		            leia(notas[i])
		            i++
		            pare
		        caso 2: 
		            //sair
		            sair = 1
		            pare
		        caso contrario:
		            escreva("opçao invalida")
		    }
		}
		
		
		inteiro tamanho = u.numero_elementos(notas)
		
		para(j = 0; j<tamanho; j++){
		    soma = soma + notas[j]
		}
		
		
		media = soma/i
		
		escreva("\n\no aluno " + aluno + " obteve a média " + media)
		
		se(media>=7.0){
		    escreva("\nparabéns! você foi aprovado\n")
		}
		senao {
		    escreva("\nvocê foi reprovado :(\n")
		}
		
		
	}
}
