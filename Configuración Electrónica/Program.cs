using System;
    class Program{
        static String[,] nivel = new String[7,4] {{"1s","2s","",""},{"2p","3s","",""},{"3p","4s","",""},{"3d","4p","5s",""},{"4d","5p","6s",""},{"4f","5d","6p","7s"},{"5f","6d","7p",""}};
        static int[,] carga = new int[7,4] {{2,2,0,0},{6,2,0,0},{6,2,0,0},{10,6,2,0},{10,6,2,0},{14,10,6,2},{14,10,6,0}};
        static int[,] cargae = new int[7,4];
        static int e=5;
        static void confige(){
            for(int h=0;h<7;h++){
                for(int i=0;i<4;i++){
                    if (carga[h,i]==0) break;
                    int s=carga[h,i];
                        for(){
                            int er=e-s;
                            cargae[h,i]=er;
                        }                    
                }
            }
        }
        static void Main(){
            //Console.Write("¿Cuántos electrónes tiene?: ");
            //int e=Int32.Parse(Console.ReadLine());

            confige();

            for(int i=0;i<7;i++){
                for(int j=0;j<4;j++){
                    if (carga[i,j]==0) break;
                    Console.Write("{0}{1} ",nivel[i,j],cargae[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }