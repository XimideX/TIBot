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
// cd + tab

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
//int recursoProducao = 0;
int recursoInicialPlanetaNatal = 3;
int recursoInicialTradeGoods = 2; 
int possuiRecursos = recursoInicialPlanetaNatal + recursoInicialTradeGoods;

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

            if (possuiDock == "1")
            {
                while (possuiRecursos >= 1)
                {
                    #region checagem de recursos
                    if (possuiRecursos >= costCarrierI)
                    {
                        prodCarrierIOK = true;
                        prodDreadnoughtIOK = false;
                        prodHillColishOK = false;
                        prodWarSunOK = false;
                    }
                    if (possuiRecursos >= costCruiserI)
                    {
                        prodCruiserIOK = true;
                        prodCarrierIOK = false;
                        prodDreadnoughtIOK = false;
                        prodHillColishOK = false;
                        prodWarSunOK = false;
                    }
                    if (possuiRecursos >= costDestroyerI)
                    {  
                        prodDestroyerIOK = true;
                        prodCruiserIOK = false;
                        prodCarrierIOK = false;
                        prodDreadnoughtIOK = false;
                        prodHillColishOK = false;
                        prodWarSunOK = false;
                    }
                    if (possuiRecursos >= costInfantryI2Uni)
                    {
                        prodInfantry2UniOK = true;
                        prodCruiserIOK = false;
                        prodCarrierIOK = false;
                        prodDreadnoughtIOK = false;
                        prodHillColishOK = false;
                        prodWarSunOK = false;
                    }
                    if (possuiRecursos >= costFighterI2Uni)
                    {
                        prodFighterI2UniOK = true;
                        prodCruiserIOK = false;
                        prodCarrierIOK = false;
                        prodDreadnoughtIOK = false;
                        prodHillColishOK = false;
                        prodWarSunOK = false;
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
                    #endregion

                    Random qntdRecursos = new Random();
                    int maxRandomRecursos = 0; 

                    if (prodDreadnoughtIOK)
                    {
                        maxRandomRecursos = costDreadnoughtI;
                    }else if (prodCarrierIOK)
                    {
                        maxRandomRecursos = costCarrierI;
                    }else if (prodCruiserIOK)
                    {
                        maxRandomRecursos = costCruiserI;
                    }else if (prodDestroyerIOK)
                    {
                        maxRandomRecursos = costDestroyerI;
                    }
                    
                    int prod = qntdRecursos.Next (1, maxRandomRecursos + 1);
                    Console.WriteLine ("teste prod selecionado " + prod);
                    int a = 0;

                    switch (prod)
                    {
                        case 1:
                            a = qntdRecursos.Next (1, 3 + 1);
                            if (a == 1)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcDestroyer);
                            }else if (a == 2)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcFighter);
                            }else if (a == 3)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcInfantry);
                            }
                        break;
                        case 2:
                            a = qntdRecursos.Next (1, 5 + 1);
                            if (a == 1)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcDestroyer);
                            }else if (a == 2 )
                            {
                                prod = 1;
                                OQueSeraProduzido (opcFighter);
                            }else if (a == 3)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcInfantry);
                            }else if (a == 4 )
                            {
                                prod = 2;
                                OQueSeraProduzido (opcMech);
                            }else if (a == 5)
                            {
                                prod = 2;
                                OQueSeraProduzido (opcCruiser);
                            }
                        break;
                        case 3:
                            a = qntdRecursos.Next (1, 6 + 1);
                            if (a == 1)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcDestroyer);
                            }else if (a == 2 )
                            {
                                prod = 1;
                                OQueSeraProduzido (opcFighter);
                            }else if (a == 3)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcInfantry);
                            }else if (a == 4 )
                            {
                                prod = 2;
                                OQueSeraProduzido (opcMech);
                            }else if (a == 5)
                            {
                                prod = 2;
                                OQueSeraProduzido (opcCruiser);
                            }else if (a == 6)
                            {
                                prod = 3;
                                OQueSeraProduzido (opcCarrier);
                            }
                        break;
                        case 4:
                            a = qntdRecursos.Next (1, 7 + 1);
                            if (a == 1)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcDestroyer);
                            }else if (a == 2 )
                            {
                                prod = 1;
                                OQueSeraProduzido (opcFighter);
                            }else if (a == 3)
                            {
                                prod = 1;
                                OQueSeraProduzido (opcInfantry);
                            }else if (a == 4 )
                            {
                                prod = 2;
                                OQueSeraProduzido (opcMech);
                            }else if (a == 5)
                            {
                                prod = 2;
                                OQueSeraProduzido (opcCruiser);
                            }else if (a == 6)
                            {
                                prod = 3;
                                OQueSeraProduzido (opcCarrier);
                            }else if (a == 7)
                            {
                                prod = 4;
                                OQueSeraProduzido (opcDreadnought);
                            }
                        break;
                    }
                    #region 
                    // if (prod == 1)
                    // {
                    //     Random escolherPeca = new Random();
                    //     a = escolherPeca.Next (1, 3 + 1);
                    //     if (a == 1)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcDestroyer);
                    //     }else if (a == 2)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcFighter);
                    //     }else if (a == 3)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcInfantry);
                    //     }
                    // }else 
                    // if (prod == 2)
                    // {
                    //     Random escolherPeca = new Random();
                    //     a = escolherPeca.Next (1, 5 + 1);
                    //     if (a == 1)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcDestroyer);
                    //     }else if (a == 2 )
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcFighter);
                    //     }else if (a == 3)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcInfantry);
                    //     }else if (a == 4 )
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcMech);
                    //     }else if (a == 5)
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcCruiser);
                    //     }
                        
                    // }else if (prod == 3)
                    // {
                    //     Random escolherPeca = new Random();
                    //     a = escolherPeca.Next (1, 6 + 1);
                    //     if (a == 1)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcDestroyer);
                    //     }else if (a == 2 )
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcFighter);
                    //     }else if (a == 3)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcInfantry);
                    //     }else if (a == 4 )
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcMech);
                    //     }else if (a == 5)
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcCruiser);
                    //     }else if (a == 6)
                    //     {
                    //         prod = 3;
                    //         OQueSeraProduzido (opcCarrier);
                    //     }
                    // }else if (prod == 4)
                    // {
                    //     Random escolherPeca = new Random();
                    //     a = escolherPeca.Next (1, 7 + 1);
                    //     if (a == 1)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcDestroyer);
                    //     }else if (a == 2 )
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcFighter);
                    //     }else if (a == 3)
                    //     {
                    //         prod = 1;
                    //         OQueSeraProduzido (opcInfantry);
                    //     }else if (a == 4 )
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcMech);
                    //     }else if (a == 5)
                    //     {
                    //         prod = 2;
                    //         OQueSeraProduzido (opcCruiser);
                    //     }else if (a == 6)
                    //     {
                    //         prod = 3;
                    //         OQueSeraProduzido (opcCarrier);
                    //     }else if (a == 7)
                    //     {
                    //         prod = 4;
                    //         OQueSeraProduzido (opcDreadnought);
                    //     }
                    // } 
                    #endregion  
                    
                    possuiRecursos = possuiRecursos - prod;
                    Console.WriteLine ("Recurso atualizado " + possuiRecursos);

                }
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

void OQueSeraProduzido (int qntasUnidades, string pecaProduzida) //nao esta pronto
{
    Console.WriteLine ("Produção: " +qntasUnidades + " unidades de " + pecaProduzida);
}
