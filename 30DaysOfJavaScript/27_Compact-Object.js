/**
 * @param {Object|Array} obj
 * @return {Object|Array}
 */
var compactObject = function (obj) {
  if (Array.isArray(obj)) {
    return obj.map(compactObject).filter(Boolean);
  } else if (obj && typeof obj === "object") {
    let iterateObj = {};
    for (let key in obj) {
      if (obj.hasOwnProperty(key) && obj[key]) {
        iterateObj[key] = compactObject(obj[key]);
      }
    }

    return iterateObj;
  } else {
    return obj;
  }
};
