// See https://aka.ms/new-console-template for more information
string[] myParams = {"1:0", "2:0", "3:0", "4:0", "2:1", "3:1", "4:1", "3:2", "4:2", "4:3"};
Console.WriteLine(TotalPoints(myParams));


static int TotalPoints(string[] games) {
    var result = 0;
    foreach (var game in games)
    {
        var score = game.Split(":").Select(x => int.Parse(x)).ToArray();

        if(score[0]>score[1]){
            result += 3;
        }
        else if (score[0]<score[1]){
            result += 0;
        }
        else{
            result += 1;
        }
    }
    return result;
}
