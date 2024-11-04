/**
 * @param {Array} arr
 * @param {number} size
 * @return {Array}
 */
var chunk = function (arr, size) {
  const chunkedArray = [];

  for (let i = 0; i < arr.length; i += size) {
    chunkedArray.push(arr.slice(i, i + size));
  }

  return chunkedArray;

  /*var currentSize = 0;
  let currentArrayElement = [];
  let resultArray = [];

  for (let i = 0; i < arr.length; i++) {
    currentArrayElement.push(arr[i]);
    currentSize++;

    if (currentSize == size) {
      resultArray.push(currentArrayElement);
      currentSize = 0;
      currentArrayElement = [];
    }
  }

  if (currentArrayElement.length > 0) {
    resultArray.push(currentArrayElement);
  }

  return resultArray;*/
};
