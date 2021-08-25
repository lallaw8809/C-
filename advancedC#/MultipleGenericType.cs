using System;

public class Example
{
	public class MultipleGenericType<T, V, S>
	{
		private T t;
		private V v;
		private S s;
		
		public T T_Value { get; set; }
		public V V_Value { get; set; }

		public void Show(S sValue, T tValue, V vValue)
		{
			Console.WriteLine("[{0}]\n\t T Value: {1}\n\t V Value: {2}", sValue, tValue, vValue);
		}
	}

    public static int Main()
    {
        MultipleGenericType<int, int, string> IntTypes = new MultipleGenericType<int, int, string>();
        IntTypes.T_Value = 1;
        IntTypes.V_Value = 2;
        IntTypes.Show("Int Types", IntTypes.T_Value, IntTypes.V_Value);

		MultipleGenericType<short, decimal, string> Disparate = new MultipleGenericType<short, decimal, string>();
        Disparate.T_Value = 3;
        Disparate.V_Value = 4;
        Disparate.Show("Disparate Types", Disparate.T_Value, Disparate.V_Value);
        
        return 0;
    }

}

/*
Output:
[Int Types]
     T Value: 1
     V Value: 2
	 
[Disparate Types]
     T Value: 3
     V Value: 4
*/