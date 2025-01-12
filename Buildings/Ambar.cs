﻿/*
 * Амбар буде місцем для зберігання ресурсів, торгівлі надлишками. 
 * В Амбарі зберігатимуться такі продовольчі товари: зерно, вино, олія, фрукти, овочі, м'ясо.
 * Також такі ресурси як: дерево, камінь, метали.
 * Цінні товари, такі як: золото, тканина.
 * 
 * 
 * Базова місткість амбару продовольства становитиме 500 одиниць на кожен вид, ресурсів - 1000од, цінних товарів - 25од., 
 * однак може бути збільшена до 1000, 2000 і 50од. відповідно.
 * 
 * 
 * (на майбутнє) можна реалізувати систему втрати товару (крадіжки, псування, неврожай і тп.
 * 
 * 
 * 
*/


using System.Security.Cryptography.X509Certificates;


namespace Sandbox1.Buildings
{
    public class Ambar : Building
    {
        public int LevelAmbar { get; set; }
        public int MaximumValue { get; set; }

        public Ambar(string address) : base(address)
        {
            
        }
    }
}
