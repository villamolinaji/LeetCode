/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
  let arrResult = [];

  for (let i = 0; i < arr.length; ++i) {
    if (fn(arr[i], i)) {
      arrResult.push(arr[i]);
    }
  }

  return arrResult;
};
