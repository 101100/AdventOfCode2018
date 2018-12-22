function test(initialZed)
{
    var A = 0;
    var B = 0;
    var C = 0;
    var D = 0;
    var E = 0;
    var Z = initialZed;

    jmp target1                 // 00: addi 3 16 3
    target4:
    A = 1;                      // 01: seti 1 7 1
    do
    {
        E = 1;                  // 02: seti 1 7 5
        do
        {
            D = A * E;          // 03: mulr 1 5 4
            if (D == B)         // 04: eqrr 4 2 4
            {                   // 05: addr 4 3 3
                                // 06: addi 3 1 3
                Z += A;         // 07: addr 1 0 0
            }
            E += 1;             // 08: addi 5 1 5
        } while(E <= B);        // 09: gtrr 5 2 4
                                // 10: addr 3 4 3
                                // 11: seti 2 2 3
        A += 1;                 // 12: addi 1 1 1
    } while (A <= B);           // 13: gtrr 1 2 4
                                // 14: addr 4 3 3
                                // 15: seti 1 5 3
    return Z;                   // 16: mulr 3 3 3
    :target1 (17)
    B += 2;                     // 17: addi 2 2 2
    B *= B;                     // 18: mulr 2 2 2
    B *= 19;                    // 19: mulr 3 2 2
    B *= 11;                    // 20: muli 2 11 2
    D += 2;                     // 21: addi 4 2 4
    D *= 23;                    // 23: mulr 4 3 4
    D += 2;                     // 23: addi 4 2 4
    B += D;                     // 24: addr 2 4 2
    jmp Z                       // 25: addr 3 0 3
    jmp target4                 // 26: seti 0 8 3
    D = 3;                      // 27: setr 3 8 4
    D *= 28;                    // 28: mulr 4 3 4
    D += 29                     // 29: addr 3 4 4
    D += 30;                    // 30: mulr 3 4 4
    D *= 14;                    // 31: muli 4 14 4
    D *= 32;                    // 32: mulr 4 3 4
    B += 2;                     // 33: addr 2 4 2
    Z = 0;                      // 34: seti 0 7 0
    jmp target4;                // 35: seti 0 9 3
}

console.log(test(0));