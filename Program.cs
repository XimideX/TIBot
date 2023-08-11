// See https://aka.ms/new-console-template for more information
//Muito bem, primeira mudanca! By: Rick


//primeiro teste by: Su

#region Comentarios de comandos
//if (condicao)  //eh sempre uma variavel comparada com a outra
//as variaveis/valores precisam ser do msm tipo. uma do lado direito e outra do lado esquerdo. 
//== igual
//!= diferente
// < > >= <= auto explicativo
// ";" eh usado para finalizar uma acao (chamada de metodo, declaracao de variavel...)
// ctrl + d = selecao multipla
// ctrl + k + c = comentar area selecionada - ctrl + k + u
// Dotnet.run - comando inicial
// ctrl + c = cancelar programa

//{
    //corpo do if =  
//}
#endregion

Console.WriteLine("Hello, World!");
#region quantidade de unidades das pecas
int carrier = 1;
int destroyers = 2;
int dreadnought = 0;
int cruiser = 0;
int fighters = 2;
int infantry = 4;
int spaceDock = 1;
int commodities = 4;
#endregion

#region informacoes
string startingTechno = "Gravity Drive";
string startingPlanets = "Creuss and Delta wormhole";
string leaders1 = "Emissary Taivra";
string leaders2 = "Sai Seravus";
string leaders3 = "Riftwalker Meian";
string habilidadeDeAcao = "acao";
string habilidadeDeEstrategia = "estrategia";
string habilidadeTatica = "tatica";
#endregion

#region variavel de permissao de mov e prod
bool isCarrierOk = false;
bool isDestroyerOK = false;
bool isDreadnoughtOk = false;
bool isCruiserOk = false;
bool prodHillColishOK = false;
bool prodWarSunOK = false; 
bool prodDreadnoughtIOK = false;
bool prodCarrierIOK = false;
bool prodCruiserIOK = false;
bool prodDestroyerIOK = false;
bool prodFighterI2UniOK = false;
bool prodInfantry2UniOK = false;
bool prodMechOK = false;
bool prodSpaceDockOK = false;
#endregion

#region relacao opcao pecas
string opcCarrier = "Carrier" ;
string opcCruiser = "Cruiser" ;
string opcDestroyer = "Destroyer";
string opcDreadnought = "Dreadnought";
string opcFighter = "Fighter";
string opcHillColish = "Hill Colish";
string opcInfantry = "Infatry";
string opcMech = "Mech";
string opcWarSun = "War Sun";
#endregion

#region custo de producao 
int costHillColish = 8;
int costWarSun = 0; //precisa de upgrade
int costDreadnoughtI = 4;
int costCarrierI = 3;
int costCruiserI = 2;
int costDestroyerI = 1;
int costFighterI2Uni = 1;
int costInfantryI2Uni = 1;
int costMech = 2;
#endregion 

#region reinforcements
int reinforcementHillColish = 0;
int reinforcementWarSun = 0; 
int reinforcementDreadnoughtI = 0;
int reinforcementCarrierI = 0;
int reinforcementCruiserI = 0;
int reinforcementDestroyerI = 0;
int reinforcementFighterI2Uni = 0;
int reinforcementInfantry2Uni = 0;
int reinforcementMech = 0;
int reinforcementSpaceDock = 0;
#endregion

#region producao/recursos
int recursoProducao = 0;
int recIniPlanetalNatal = 3;
int recIniTradeGoods = 2; 
#endregion



while (true)
{
    //randomizar essa parte qndo todos os menus estiverem prontos
    Console.WriteLine( " \n O que deseja fazer?");
    Console.WriteLine (" 1: Acao \n 2: Estrategia \n 3: Tatica");
    string leituraRespostaAcao = Console.ReadLine();
    Console.WriteLine (leituraRespostaAcao);

    if (leituraRespostaAcao == "1") 
    {
        Console.WriteLine (" \n Opcao 1 foi selecionada");
    }else if (leituraRespostaAcao == "2") 
    {
        Console.WriteLine (" \n Opcao 2 foi selecionada");
    }else if (leituraRespostaAcao == "3") 
    {
        //não precisa do Console.writeLine pq isso precisa ser uma escolha do bot
        
        #region movimentos  
        Console.WriteLine ("Opcao 1: um movimento \n Opcao 2: dois movimentos \n Opcao 3: tres movimentos");
        string qntosmovimentos = Console.ReadLine();
        Console.WriteLine (qntosmovimentos);

        if (qntosmovimentos == "1")    
        {
            if (carrier >= 1)
            {
                isCarrierOk = true;
            }

            if (destroyers >= 1)
            {
                isDestroyerOK = true;
            }

            if (cruiser >= 1)
            {  
                isCruiserOk = true;
            }
            
            if (dreadnought >= 1) 
            {
                isDreadnoughtOk = true;
            }

            Random pecaSelecionada = new Random();
            int opcaoPeca = pecaSelecionada.Next (1, 4 + 1);
            string essaOpcao = string.Empty; 

            if (opcaoPeca == 1)  
            { 
                if (isCarrierOk)
                {
                    primeiroMetodo (opcCarrier, carrier);
                } else
                {
                    semPecasParaMover (opcCarrier);
                }
                
            } else if (opcaoPeca == 2)
            {
                if (isCruiserOk)
                {
                    primeiroMetodo (opcCruiser, cruiser);
                } else
                {
                    semPecasParaMover (opcCruiser);
                }
            } else if (opcaoPeca == 3) 
            {
                if (isDestroyerOK)
                {
                    primeiroMetodo (opcDestroyer, destroyers);
                } else
                {
                    semPecasParaMover (opcDestroyer);
                }
            } else if (opcaoPeca == 4) 
            {
                if (isDreadnoughtOk)
                {
                    primeiroMetodo (opcDreadnought, dreadnought);
                } else
                {
                    semPecasParaMover (opcDreadnought);
                }
            } 
        }   

        if (qntosmovimentos == "2")
        { 
            if (destroyers >= 1)
            {
                isDestroyerOK = true;
            }

            if (cruiser >= 1)
            {  
                isCruiserOk = true;
            }
            
            Random pecaSelecionada = new Random();
            int opcaoPeca = pecaSelecionada.Next (1, 2 + 1);
            string essaOpcao = string.Empty; 

            if (opcaoPeca == 1)
            {
                if (isCruiserOk)
                {
                    primeiroMetodo (opcCruiser, cruiser);
                } else
                {
                    semPecasParaMover (opcCruiser);
                }
            } else if (opcaoPeca == 2) 
            {
                if (isDestroyerOK)
                {
                    primeiroMetodo (opcDestroyer, destroyers);
                } else
                {
                    semPecasParaMover (opcDestroyer);
                }
            }
        }//else??
        #endregion

        #region producao
        Console.WriteLine ("Esse sistema possui Space Dock? /n 1: sim /n 2:nao")
        string possuiDock = Console.ReadLine ();
        //criar um WHILE para produzir ate esgotar os recursos ou atingir capacidade de producao de pecas
        
        if (possuiDock == "1")
        {
            int possuiRecursos = recIniPlanetalNatal + recIniTradeGoods;

            if (possuiRecursos >= 1)
            {
                Console.WriteLine ("O que deseja produzir? /n 1: Dreadnought I /n 2: Carrier I /n 3: Cruiser I /n 4: Destroyer I /n 5: Fighter I /n 6:Infantry /n 7: Mech");
                // Random oQueProduzir = new Random();
                // int prod = oQueProduzir.Next (1, 7 + 1); 
        
                if (oQueProduzir == 1)  
                { 
                    if ( ) //o que colocar aqui?
                    {
                        podeProduzir (opcCarrier, reinforcementCarrierI);
                    } else
                    {
                        //semPecasParaMover (opcao1);
                    }
                    
                // } else if (oQueProduzir == 2)
                // {
                //     if (isCarrierOk)
                //     {
                //         podeProduzir (opcCruiser, cruiser);
                //     } else
                //     {
                //         semPecasParaMover (opcao2);
                //     }
                // } else if (opcaoPeca == 3) 
                // {
                //     if (isDestroyerOK)
                //     {
                //         podeProduzir (opcDestroyer, destroyers);
                //     } else
                //     {
                //         semPecasParaMover (opcao3);
                //     }
                // } else if (opcaoPeca == 4) 
                // {
                //     if (isDreadnoughtOk)
                //     {
                //         podeProduzir (opcDreadnought, dreadnought);
                //     } else
                //     {
                //         semPecasParaMover (opcao4);
                //     }
                 }
            }

         


            



        }
        #endregion
    }     
}

void primeiroMetodo (string nomeDaNave, int qntidadeDePecas) //void = retorno vazio
{
    Console.WriteLine (nomeDaNave + " foi selecionado");
    Random qntdadePecasCarrier = new Random(); 
    int z = qntdadePecasCarrier.Next(qntidadeDePecas + 1);
    Console.WriteLine ("Quantidade de peças que serao usadas " + z);
}

void semPecasParaMover (string nomeDaPeca)
{
    Console.WriteLine (nomeDaPeca + " nao possui pecas suficientes para movimentar");
}

void podeProduzir (string pecaAProduzir, int qntidadeDePecasAProduzir)
{
    Console.WriteLine (pecaAProduzir + " será produzido");
    Random qntdadePecasProducao = new Random(); 
    int qntidade = qntdadePecasProducao.Next(qntidadeDePecasAProduzir + 1);
    Console.WriteLine ("Quantidade de peças que sera produzida: " + qntidade);
}

