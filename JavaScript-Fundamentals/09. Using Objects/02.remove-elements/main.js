'use strict';

function solve(params) {
    const elementToRemove = params[0];

    let resultArray = [];

    for (let i = 0; i < params.length; i += 1) {
        if(params[i] !== elementToRemove) {
            resultArray.push(params[i]);
        }
    }

    console.log(resultArray.join("\r\n"));
}

solve([
  '_h/_',
  '^54F#',
  'V',
  '^54F#',
  'Z285',
  'kv?tc`',
  '^54F#',
  '_h/_',
  'Z285',
  '_h/_',
  'kv?tc`',
  'Z285',
  '^54F#',
  'Z285',
  'Z285',
  '_h/_',
  '^54F#',
  'kv?tc`',
  'kv?tc`',
  'Z285'
]);