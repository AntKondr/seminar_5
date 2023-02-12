Console.Clear();
Console.Write("seminar_5 task_add\n\n");

void printArray(ref int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]} ");
    }
    Console.Write("\b\n");
}

int[] randomArray(int length=10, int min=0, int max=10){
    int[] array = new int[length];
    for (int i = 0; i < length; i++){
        array[i] = new Random().Next(min, max);
    }
    return array;
}

bool isEvenNum(ref int num){
    if (num % 2 == 0){
        return true;
    }
    else {
        return false;
    }
}

int[] even_or_odd_days(ref int[] days, bool need_odd){
    int amount = 0;
    for (int i = 0; i < days.Length; i++){
        if (isEvenNum(ref days[i]) ^ need_odd){
            amount += 1;
        }
    }
    int[] needed_days = new int[amount];
    int k = 0;
    for (int i = 0; i < days.Length; i++){
        if (isEvenNum(ref days[i]) ^ need_odd){
            needed_days[k] = days[i];
            k += 1;
        }
    }
    return needed_days;
}

int input(string message=""){
    Console.Write(message);
    int data = Convert.ToInt32(Console.ReadLine());
    return data;
}

string yes_or_no(ref int[] odd_days, ref int[] even_days){
    if (even_days.Length >= odd_days.Length){
        return "YES";
    }
    else {
        return "NO";
    }
}


Console.Write("input:\n");
int days_amount = input("input days amount: ");
int[] days = randomArray(length: days_amount, min: 1, max: 32);
int[] odd_days = even_or_odd_days(ref days, need_odd: true);
int[] even_days = even_or_odd_days(ref days, need_odd: false);
printArray(ref days);
Console.Write("\noutput:\n");
printArray(ref odd_days);
printArray(ref even_days);
Console.Write(yes_or_no(ref odd_days, ref even_days));