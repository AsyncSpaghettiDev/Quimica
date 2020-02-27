using System;

    class Program{
        static void Main(){
            String[] nivel = new String[4]{"s","p","d","f"};
            Int16[] carga = new Int16[]{2,2,6,2,6,2,10,6,2,10,6,2,14,10,6,2,14,10,6};

            Console.Write("¿Cuántos electrónes tiene?: ");
            Int16 e=Int16.Parse(Console.ReadLine());

            int n;
            for(int i=1;i<=7;i++){
                for(int j=0;j<4;j++){
                    for(int k=0;k<=e;k++){
                        n=carga[k];
                        Console.Write("{0}{1}{2} ",i,nivel[j],n);
                        if (n==e) break;
                    }
                    Console.WriteLine();
                }
            }
        }
    }