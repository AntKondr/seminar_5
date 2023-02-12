Console.Clear();
Console.Write("seminar_5 task_38\n\n");

void print_array(ref double[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]},  ");
    }
    Console.Write("\b\b\b]\n");
}

double[] random_double_array(int length=10, int min=0, int max=10, int afterDot=2){
    double[] array = new double[length];
    for (int i = 0; i < length; i++){
        array[i] = Math.Round(new Random().NextDouble() + new Random().Next(min, max), afterDot);
    }
    return array;
}

string diff_max_min(ref double[] array){
    double min = array[0];
    double max = array[0];
    for (int i = 1; i < array.Length; i++){
        if (array[i] < min){
            min = array[i];
        }
        else if (array[i] > max){
            max = array[i];
        }
    }
    return $"{max} - {min} = {Math.Round(max - min, 2)}";
}

double[] arr = random_double_array(length: new Random().Next(5, 14), max: 100);
print_array(ref arr);
Console.Write(diff_max_min(ref arr));