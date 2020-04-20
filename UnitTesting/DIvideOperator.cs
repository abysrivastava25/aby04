using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTesting
{
   public class DIvideOperator
    {
        private double? _numericResult;
        public DIvideOperator()
        {
        }


        // evaluate method to divide 2 numeric numbers
        public object Evaluate(List<object> data)
        {

            object result;
            foreach (object value in data)
            {
                if (value.IsNumeric())
                {

                    if (_numericResult == null)
                    {
                        _numericResult = Convert.ToDouble(value);
                    }

                    else
                    {
                        try
                        {
                            _numericResult = _numericResult.Value / Convert.ToDouble(value);
                        }
                        catch (DivideByZeroException)
                        {
                            throw new ArgumentException($"Divide by zero is not possible");
                        }
                        catch (Exception)
                        {
                            throw new ArgumentException($"Enter valid number");
                        }

                    }

                }
                else
                {
                    throw new ArgumentException($"Non numeric or string value encountered");
                }
            }

            if (_numericResult != null)
            {
                result = _numericResult.Value;
            }
            else
            {
                throw new ArgumentException($"Incorrect arguments encountered in {nameof(DIvideOperator)}");
            }
            return result;
        }
    }

}
