Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


// Your code goes here

if (daysUntilExpiration <= 5) {
    discountPercentage = 10;
}
if (daysUntilExpiration <= 1) {
    discountPercentage = 20;
}

if (daysUntilExpiration <= 1){
    Console.WriteLine($"Your subscription ends within a day, renew now and save {discountPercentage}% ");
}
else if  (daysUntilExpiration <=5){
    Console.WriteLine($"your subscription expires in {daysUntilExpiration} days, renew now and save {discountPercentage}%");

}
else if (daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription will expire soon, Renew now!");
}


