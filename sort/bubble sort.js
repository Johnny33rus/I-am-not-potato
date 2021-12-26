function bubbleSort() {
    let array = [4, 1, 6, 3, 5];
        for (let i = 0; i < array.length; i++) {
                for (let j = 0; j < array.length; j++) {
                    if (array[j]>array[j+1]) {
                        let p = array[j];
                        array[j] = array[j+1];
                        array[j+1] = p;
                    }
                }        
        }
         console.log(array.join(' '));
    }
bubbleSort();