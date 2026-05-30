/**
 * Get the outer sizes of the given element (offset size + margins)
 * @method
 * @memberof Popper.Utils
 * @argument {Element} element
 * @returns {Object} object containing width and height properties
 */
export default function getOuterSizes(element) {
  const window = element.ownerDocument.defaultView;
  const styles = window.getComputedStyle(element);
  const x = Number.parseFloat(styles.marginTop || 0) + Number.parseFloat(styles.marginBottom || 0);
  const y = Number.parseFloat(styles.marginLeft || 0) + Number.parseFloat(styles.marginRight || 0);
  const result = {
    width: element.offsetWidth + y,
    height: element.offsetHeight + x,
  };
  return result;
}
