using System;

namespace DesignPattern.初入设计模式
{
	public class Divide : Methon
	{
		public decimal Execute(decimal left, decimal right)
		{
			if (right == 0)
			{
				throw new DivideByZeroException("Division by zero is not allowed.");
			}
			return left / right;
		}
	}
}