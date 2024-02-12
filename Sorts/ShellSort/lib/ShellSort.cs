namespace lib;

public static class ShellSort
{
    public static int[] Sort(int[] array) {
        //Считаешь интервал для замены
        for (int step = array.Length / 2; step > 0; step/=array.Length)
        {
            //Считаешь количество элементов для проверки с данным интервалом
            for (int i = step; i < array.Length; i++)
            {
                //Логика свапа и проверка граничных условий
                for(int j = i - step; j >= 0 && array[j] > array[j + step]; j -= step) {
                    if (array[j] < array[j + step])
                    {
                        int temp = array[j];
                        array[j] = array[j + step];
                        array[j + step] = temp; 
                    }
                }
            }
        }
        
        return array;
    }
}
