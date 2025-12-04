# 🧮 Modular Arithmetic
Most DSA problems involve extremely large numbers (combinatorics, DP, exponentiation, hashing):
- Prevent overflow
- Keep numbers manageable
- Since answers may be huge, use modulo in output
- Enables efficient calculations like modular inverse, fast exponentiation, modulo multiplication

Typical mod used in coding challenges:

```csharp
M = 10^9 + 7  (a large prime)
```

## Basic Properties (Very Important for Interviews)
Let **m** be the modulus.

For any integers **a** and **b**:

1. **Addition**
```csharp
    (a+b)%m = ((a%m) + (b%m))%m
```

2. **Subtraction**
```csharp
    (a-b)%m = ((a%m) - (b%m) + m )%m
```
(Add m to avoid negative values.)

3. **Multiplication**
```csharp
    (a*b)%m = ((a%m) * (b%m))%m
```

4. **Division**
```csharp
    (a/b)%m = ((a%m) * (pow(b,-1)*m))%m
```
