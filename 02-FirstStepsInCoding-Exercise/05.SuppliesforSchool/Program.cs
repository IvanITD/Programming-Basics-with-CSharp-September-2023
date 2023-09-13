int penPacketAmount = int.Parse(Console.ReadLine());
int markerPacketAmount  = int.Parse(Console.ReadLine());
int cleaningDetergentAmount = int.Parse(Console.ReadLine());
int discountPercent = int.Parse(Console.ReadLine());


double penPacketPrice = penPacketAmount * 5.80;
double markerPacketPrice = markerPacketAmount * 7.20;
double cleaningDetergentPricePerLiter = cleaningDetergentAmount * 1.20;

double totalPrice = penPacketPrice + markerPacketPrice + cleaningDetergentPricePerLiter;

double discount = (double)discountPercent / 100;

double result = totalPrice - (totalPrice * discount);

Console.WriteLine(result);