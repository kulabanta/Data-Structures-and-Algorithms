# 1️⃣ What is GCD?
**✔️ Definition**<br>
The GCD (Greatest Common Divisor) of two numbers a and b is the largest positive integer that divides both a and b without leaving a remainder.

**✔️ Examples**
1. gcd(12, 8) = 4
2. gcd(18, 24) = 6
3. gcd(7, 13) = 1 (since they are co-prime)

## Euclidean Algorithm

The Euclidean Algorithm is the most efficient way to compute GCD.

**✔️ Key Idea**

    The GCD of two numbers does not change if the larger number is replaced by its difference with the smaller number.

But instead of repeated subtraction, we use modulo (%), which is subtraction done efficiently.

✔️ Formula
```matlab
gcd(a, b) = gcd(b, a % b)
```
Continue until:
```matlab
gcd(a, 0) = a
```

## Euclidean Algorithm — Step-by-Step
To compute gcd(a, b):

**Algorithm**
1. If b = 0 → GCD = a<br>
2. Otherwise gcd(a, b) = gcd(b, a % b)

Repeat until the remainder becomes 0.

## Recursive Implementation (Pseudocode)
```csharp
public int GCD(int a,int b)
{
    if(b == 0)
        return a;
    else if(a<b)
        return GCD(b,a);
    else
        return GCD(b,a%b);
}
```
## Iterative Implementation (Pseudocode)
```csharp
public int gcd(a, b){
    while (b != 0)
    {
        int temp = b;
        b = a % b;
        a = temp;
    }
    return a;
}
```
## Time Complexity
**✔️ Time Complexity**: O(log(min(a, b)))

Much faster than the naive method (O(min(a, b))).

## Key Mathematical Properties of GCD (Useful in Interviews)
**✔️ Property 1**

gcd(a, 0) = |a|

**✔️ Property 2**

gcd(a, b) = gcd(b, a % b)

**✔️ Property 3**

gcd(a, b, c) = gcd(gcd(a, b), c)

**✔️ Property 4**

If gcd(a, b) = d, then gcd(a/d, b/d) = 1 (they are co-prime)

**✔️ Property 5**

Relation with LCM:
```csharp
lcm(a, b) = (a * b) / gcd(a, b)
```

## ✅ Quick Summary (For Interview Revision)
- GCD = greatest number dividing both a and b

- Euclidean Algorithm:
    - gcd(a, b) = gcd(b, a % b)

- Base case:
    - gcd(a, 0) = a

- Time complexity: `O(log n)`

- Used in modular arithmetic, LCM, fraction reduction, cryptography

## Extended Euclidean Algorithm
The Extended Euclidean Algorithm is an extension of the normal Euclidean algorithm that calculates:
- gcd(a, b)
- and also two integers x and y such that:
```csharp
a*x + b*y = gcd(a, b)
```
This is called **Bézout’s Identity**.

### Why Do We Need It?
**✔️ 1. Finding Modular Inverse**

To compute:
```css
a⁻¹ mod m
```
We need x such that:
```csharp
a*x + m*y = 1  →  x is the inverse
```

This works when gcd(a, m) = 1.

**✔️ 2. Solving Linear Diophantine Equations**

Equations like:
```csharp
ax + by = c
```
**✔️ 3. Number theory problems & cryptography**

Used in RSA, modulo operations, etc.

### How the Extended Algorithm Works (Intuition)
When computing `gcd(a, b)` using:
```css
gcd(a, b) → gcd(b, a % b)
```
We also track how the gcd is expressed as a combination of a and b.

The identifier:
```csharp
a*x + b*y = gcd(a, b)
```

We compute `(x, y)` during the backtracking.

**Base Case**
If:
```ini
b = 0
```
Then:
```makefile
gcd(a, 0) = a
x = 1
y = 0
```
Because:
```
a*1 + 0*0 = a
```

**Recursive Step**
Suppose:
```
gcd(b, a % b) = b*x1 + (a % b)*y1
```

Since:
```
a % b = a - floor(a/b) * b
```

Substitute:
```
gcd = b*x1 + (a - (a//b)*b)*y1
```

Rearrange:
```
gcd = a*y1 + b*(x1 - (a//b)*y1)
```

Thus the new coefficients are:
```
x = y1
y = x1 - (a // b) * y1
```
### PseudoCode
```csharp
public List<int> Extended_GCD(int a,int b)
{
    if(b == 0)
    {
        return new List<int>{a,1,0};
    }
    else if(a<b)
    {
        return Extended_GCD(b,a);
    }
    else{
        var res = Extended_GCD(b,a%b);
        int x = res[2];
        int y = res[1]-Math.Floor(a/b)*res[2];
        return new List<int>{res[0],x,y};
    }
}
```