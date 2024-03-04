import results from './data/image-results'
const fetch = (mockData, time = 0) => {
  return new Promise((resolve) => {
    setTimeout(() => {
      resolve(mockData)
    }, time)
  })
}
export default {
  analyze () {
    return fetch(results, 1000) // wait 1s before returning posts
  }
}