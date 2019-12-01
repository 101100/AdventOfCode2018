const Z = 0; // starting value of register 0
let A = 0;
let B = 0;
let D = 0;
let E = 0;

A = 123;                   // 00: seti 123 0 1
do {
    // target a1:
    A = A & 456;               // 01: bani 1 456 1
} while (A != 72)
// A = A == 72 ? 1 : 0;        // 02: eqri 1 72 1
// jmp + A;                    // 03: addr 1 3 3
// jmp a1;                     // 04: seti 0 0 3

A = 0;                         // 05: seti 0 7 1

do {
    // target a4:
    D = A | 65536;              // 06: bori 1 65536 4
    A = 3798839;                // 07: seti 3798839 3 1
    while (true) {

        // target a6:
        E = D & 255;                // 08: bani 4 255 5
        A += E;                     // 09: addr 1 5 1
        A = A & 0xFFFFFF;           // 10: bani 1 16777215 1
        A *= 65899;                 // 11: muli 1 65899 1
        A = A & 0xFFFFFF;           // 12: bani 1 16777215 1

        // console.log(`Line 13: A = ${A}, B = ${B}, D = ${D}, E = ${E}`);
        if (256 > D) {
            console.log(`A = ${A}`);
            break;
            // E = 256 > D ? 1 : 0;        // 13: gtir 256 4 5
            // jmp + E;                    // 14: addr 5 3 3
            // jmp + 1;                    // 15: addi 3 1 3
            // jmp a5;                     // 16: seti 27 6 3
        }
        E = 0;                          // 17: seti 0 2 5

        // console.log("here 1");
        do {
            // target a3:
            B = E + 1;                  // 18: addi 5 1 2
            B *= 256;                   // 19: muli 2 256 2
            if (B <= D) {
                E += 1;                     // from line 24 if looping
                B = 0;
            }
        } while (B <= D)
        B = 1;
        // B = B > D ? 1 : 0;          // 20: gtrr 2 4 2
        // jmp + B;                    // 21: addr 2 3 3
        // jmp + 1;                    // 22: addi 3 1 3
        // jmp a2;                     // 23: seti 25 3 3
        // E += 1;                     // 24: addi 5 1 5
        // jmp a3;                     // 25: seti 17 1 3

        // console.log(`Line 26: A = ${A}, B = ${B}, D = ${D}, E = ${E}`);
        // target a2:
        D = E;                         // 26: setr 5 6 4
        // jmp a6;                     // 27: seti 7 8 3
    }

    // target a5:
} while (A != Z)
// E = A == Z ? 1 : 0          // 28: eqrr 1 0 5
// jmp + E;                    // 29: addr 5 3 3
// jmp a4;                     // 30: seti 5 6 3
