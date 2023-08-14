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
        Console.WriteLine ("1: movimento /n 2: produção");
        //colocar Random aqui
        string opcTatica = Console.ReadLine();

       #region movimentos 
        if (opcTatica == "1")
        {
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
                        PrimeiroMetodo (opcCarrier, carrier);
                    } else
                    {
                        SemPecasPMover (opcCarrier);
                    }
                    
                } else if (opcaoPeca == 2)
                {
                    if (isCruiserOk)
                    {
                        PrimeiroMetodo (opcCruiser, cruiser);
                    } else
                    {
                        SemPecasPMover (opcCruiser);
                    }
                } else if (opcaoPeca == 3) 
                {
                    if (isDestroyerOK)
                    {
                        PrimeiroMetodo (opcDestroyer, destroyers);
                    } else
                    {
                        SemPecasPMover (opcDestroyer);
                    }
                } else if (opcaoPeca == 4) 
                {
                    if (isDreadnoughtOk)
                    {
                        PrimeiroMetodo (opcDreadnought, dreadnought);
                    } else
                    {
                        SemPecasPMover (opcDreadnought);
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
                        PrimeiroMetodo (opcCruiser, cruiser);
                    } else
                    {
                        SemPecasPMover (opcCruiser);
                    }
                } else if (opcaoPeca == 2) 
                {
                    if (isDestroyerOK)
                    {
                        PrimeiroMetodo (opcDestroyer, destroyers);
                    } else
                    {
                        SemPecasPMover (opcDestroyer);
                    }
                }
            }//else??
        }
        #endregion

        #region producao
        if (opcTatica == "2")
        {
            Console.WriteLine ("Esse sistema possui Space Dock? /n 1: sim /n 2:nao");
            string possuiDock = Console.ReadLine ();
            //criar um WHILE para produzir ate esgotar os recursos ou atingir capacidade de producao de pecas

            int possuiRecursos = recIniPlanetalNatal + recIniTradeGoods;
            
            if (possuiDock == "1")
            {
                if (possuiRecursos >= costCarrierI)
                {
                    prodCarrierIOK = true;
                }

                if (possuiRecursos >= costCruiserI)
                {
                    prodCruiserIOK = true;
                }

                if (possuiRecursos >= costDestroyerI)
                {  
                    prodDestroyerIOK = true;
                }
                
                if (possuiRecursos >= costDreadnoughtI) 
                {
                    prodDreadnoughtIOK = true;
                }

                if (possuiRecursos >= costHillColish) 
                {
                    prodHillColishOK = true;
                }

                if (possuiRecursos >= costWarSun) 
                {
                    prodWarSunOK = true;
                }

                //TODO 
                //It can only produce the units that it has resource for.
                // 1, 8 is not the answer, because it covers all the units avaiable.
                //The max random number must be the number of the ship that matches the amount of the resources avaiable. If the bot has resource for all ships, then it'd be
                //7. But it hasn't, so... you must specify what is the higher number that can be sorted on random method.                    
               // Console.WriteLine ("O que deseja produzir? /n 1: Destroyer I  /n 2: Fighter I  /n 3: Infantry  /n 4: Mech /n 5: Cruiser I /n 6: Carrier I /n 7: Dreadnought I /n 8: Hill Colish /n 9: War Sun");
                Random qntdRecursos = new Random();
                int maxRandom = 0; 

                if (prodDreadnoughtIOK)
                {
                    maxRandom = costDreadnoughtI;
                }else if (prodCarrierIOK)
                {
                    maxRandom = costCarrierI;
                }else if (prodCruiserIOK)
                {
                    maxRandom = costCruiserI;
                }else if (prodDestroyerIOK)
                {
                    maxRandom = costDestroyerI;
                }
                
                int prod = qntdRecursos.Next (1, maxRandom + 1);
                int x = 0;

                switch (prod)
                {
                    case 1:
                        x = qntdRecursos.Next (1, 3 + 1);
                        break;
                    case 2:
                        x = qntdRecursos.Next (1, 5 + 1);
                        break;
                    case 3:
                        x = qntdRecursos.Next (1, 6 + 1);
                        break;
                    case 4:
                        x = qntdRecursos.Next (1, 7 + 1);
                        break;
                }

                if (x == 1)
                {
                    OQueSeraProduzido (opcDestroyer);
                }else if (x == 2)
                {
                    OQueSeraProduzido (opcFighter);
                }else if (x == 3)
                {
                    OQueSeraProduzido (opcInfantry);
                }else if (x == 4)
                {
                    OQueSeraProduzido (opcMech);
                }else if (x == 5)
                {
                    OQueSeraProduzido (opcCruiser);
                }else if (x == 6)
                {
                    OQueSeraProduzido (opcCarrier);
                }else if (x == 7)
                {
                    OQueSeraProduzido (opcDreadnought);
                }
                


                // if (prod == 2)
                // {
                //     x = qntdRecursos.Next (1, 5 + 1);
                // }
                //  if (prod == 1)
                // {
                //     x = qntdRecursos.Next (1, 3 + 1);
                // }
                // if (prod == 3)
                // {
                //     x = qntdRecursos.Next (1, 6 + 1);
                // }
                // if (prod == 4)
                // {
                //     x = qntdRecursos.Next (1, 7 + 1);
                // }
            
            }
        }
        #endregion
    }     
}

void PrimeiroMetodo (string nomeDaNave, int qntidadeDePecas) //void = retorno vazio
{
    Console.WriteLine (nomeDaNave + " foi selecionado");
    Random qntdadePecasCarrier = new Random(); 
    int z = qntdadePecasCarrier.Next(qntidadeDePecas + 1);
    Console.WriteLine ("Quantidade de peças que serao usadas " + z);
}

void SemPecasPMover (string nomeDaPeca)
{
    Console.WriteLine (nomeDaPeca + " nao possui pecas suficientes para movimentar");
}

void OQueSeraProduzido (string pecaProduzida)
{
    Console.WriteLine ("Peca a ser produzida: "+ pecaProduzida);
}

// void podeProduzir (string pecaAProduzir, int qntidadeDePecasAProduzir)
// {
//     Console.WriteLine (pecaAProduzir + " será produzido");
//     Random qntdadePecasProducao = new Random(); 
//     int qntidade = qntdadePecasProducao.Next(qntidadeDePecasAProduzir + 1);
//     Console.WriteLine ("Quantidade de peças que sera produzida: " + qntidade);
// }
