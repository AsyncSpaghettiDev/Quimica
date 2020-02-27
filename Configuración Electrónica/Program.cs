using System;

    class Program{
        int Config(int e){
            for(int i=0)
        }
        static void Main(){
            String[,] nivel = new String[7,4] {{"1s","2s","",""},{"2p","3s","",""},{"3p","4s","",""},{"3d","4p","5s",""},{"4d","5p","6s",""},{"4f","5d","6p","7s"},{"5f","6d","7p",""}};
            Int16[,] carga = new Int16[7,4] {{2,2,0,0},{6,2,0,0},{6,2,0,0},{10,6,2,0},{10,6,2,0},{14,10,6,2},{14,10,6,0}};

            Console.Write("¿Cuántos electrónes tiene?: ");
            Int16 e=Int16.Parse(Console.ReadLine());

            for(int i=0;i<7;i++){
                for(int j=0;j<4;j++){
                    if (carga[i,j]==0) break;
                    Console.Write("{0}{1} ",nivel[i,j],carga[i,j]);
                }
                Console.WriteLine();
            }
            
        }
    }