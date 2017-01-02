'use strict';

class listNode {
    constructor(value) {
        this._value = value;
    }

    get() {
        return this._value;
    }
}

class LinkedList {
    constructor() {
        this._length = 0;
        this._nodes = [];
        this._first = null;
        this._last = null;
    }

    append(value) {
        for (let i = 0; i < arguments.length; i += 1) {
            if (this._length === 0) {
                this._first = arguments[0];
                i += 1;
                this._length += 1;
                this._nodes.push(arguments[0]);
            }
            this._nodes.push(arguments[i]);
            this._length += 1;
        }
        this._last = arguments[arguments.length - 1];

        return this;
    }

    get length() {
        return this._length;
    }

    get first() {
        return this._first;
    }

    get last() {
        return this._last;
    }

    prepend(value) {
        this._nodes.splice(0, 0, ...arguments);
        this._first = arguments[0];
        this._length += arguments.length;
        return this;
    }

    insert(position, ...values) {
        let arr = [...values];
        this._nodes.splice(position, 0, ...values);
        this._length += arr.length;
        this._first = this._nodes[0];
        this._last = this._nodes[this._length - 1];
        return this;
    }

    removeAt(position) {
        let value = this._nodes.splice(position, 1);
        this._length -= 1;
        this._first = this._nodes[0];
        this._last = this._nodes[this._length - 1];
        return value[0];
    }

    at(index, value) {
        if (arguments.length == 2) {
            this._nodes[index] = value;
            if (index === 0) {
                this._first = value;
            }else if(index === this._length - 1){
                this._last = value;
            }
            return this;
        } else {
            return this._nodes[index];
        }
    }

    toArray() {
        return this._nodes;
    }

    [Symbol.iterator]() {
        let index = 0;
        return {
            next: () => {
                let value = this._nodes[index];
                let done = index >= this._length;
                index++;
                return { value, done };
            }
        };
    }
    toString() {
        return this._nodes.join(' -> ');
    }

}

let list = new LinkedList();

list.append(1, 2, 3, 4, 5);

for (let i = 0; i < list.length; i += 1) {
    list.at(i, i);
}

console.log(list.toString());

module.exports = LinkedList;