/**
 * @param {Array} arr1
 * @param {Array} arr2
 * @return {Array}
 */
var join = function (arr1, arr2) {
  const arrResult = {};

  for (let i = 0; i < arr1.length; i++) {
    arrResult[arr1[i].id] = arr1[i];
  }

  for (let i = 0; i < arr2.length; i++) {
    if (arrResult[arr2[i].id]) {
      for (const key in arr2[i]) arrResult[arr2[i].id][key] = arr2[i][key];
    } else {
      arrResult[arr2[i].id] = arr2[i];
    }
  }

  return Object.values(arrResult);
};
