Console.Clear();
Console.Write("seminar_5 task_36\n\n");

void print_array(ref int[] array){
    Console.Write("[");
    for (int i = 0; i < array.Length; i++){
        Console.Write($"{array[i]}, ");
    }
    Console.Write("\b\b]\n");
}

int[] random_array(int length=10, int min=100, int max=1000){
    int[] array = new int[length];
    for (int i = 0; i < length; i++){
        array[i] = new Random().Next(min, max);
    }
    return array;
}

bool is_even(ref int num){
    if (num % 2 == 0){
        return true;
    }
    else {
        return false;
    }
}

int sum_of_odd_indexes(ref int[] array){
    int last = array.Length - 1;
    if (is_even(ref last)){
        last -= 1;
    }
    int sum = 0;
    for (int i = 1; i < last + 1; i += 2){
        sum += array[i];
    }
    return sum;
}


int[] arr = random_array(length: new Random().Next(5, 14), min: -99, max: 100);
print_array(ref arr);
Console.Write($"summ of odd indexes = {sum_of_odd_indexes(ref arr)}");