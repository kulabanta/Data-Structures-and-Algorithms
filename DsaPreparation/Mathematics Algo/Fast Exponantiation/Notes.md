# Fast exponentiation

**Fast exponentiation** is an efficient algorithm to compute:

```
a^b   (a raised to b)
```

instead of multiplying a by itself b times.

**❌ Naive approach**

```
a * a * a * ... (b times) → O(b)
```

**✔ Fast Exponentiation**

Uses the idea of divide and conquer and binary representation of exponent b.

Time Complexity: `O(log b)`

This is mandatory knowledge for:

1. Coding interviews
2. Competitive programming
3. Modular arithmetic problems
4. Cryptography algorithms
5. Efficient power computation

## Key Insight Behind Fast Exponentiation

A number `b` can be written in binary:

Example:

```ini
13 = 1101 (binary)
```

Which means:

```
a^13 = a^(8 + 4 + 1)
     = a^8 * a^4 * a^1
```

So instead of computing 13 multiplications, we compute powers of 2:

```
a^1, a^2, a^4, a^8, ...
```

This allows exponent computation in logarithmic time.

## Code

1. [Fast Exponantiation Recursive ](./FastExponatiationRec.cs)
2. [Fast Exponantiation Iterative ](./FasExponantiationIter.cs)

## Fast Modular Exponentiation (VERY IMPORTANT)

Most DSA problems require:

```
(a^b) % m
```

Direct computation will overflow.

So we do:

```
result = (result * a) % m
a = (a * a) % m
```

Formula:

```csharp
    public int Power(int a, int b, int m)
    {
        int  ans = 1;
        a = a % m;
        while (b > 0)
        {
            if (b % 2 == 1)
            {
                ans = (ans * a)%m;
                b = b-1;
            }
            else{
            a = (a * a)%m;
            b = b / 2;
          }
        }
        return ans;
    }
```
## Time Complexity
| Method                       | Time         |
| ---------------------------- | ------------ |
| Naive multiplication         | O(b)         |
| Fast Exponentiation (Binary) | **O(log b)** |

**Modular Inverse using Fermat’s Little Theorem**
Requires:
```csharp
a^(m-2) % m   (when m is prime)
```
