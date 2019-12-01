const Z = 0; // starting value of register 0

function getNextA(oldA) {
    let D = oldA | 65536;
    let A = 3798839;
    while (true) {

        A += D & 255;
        A = A & 0xFFFFFF;
        A *= 65899;
        A = A & 0xFFFFFF;

        if (D < 256) {
            return A;
        }

        D = D / 256;
    }
}

let A = 0;
let lastA;
let seenAs = {};
do {
    A = getNextA(A);
    if (seenAs[A]) {
        console.log(`Final unique A: ${lastA}`);
        return;
    }
    // console.log(`A = ${A}`);
    seenAs[A] = true;
    lastA = A;
} while (A != Z)
