import axios from 'axios'

const axiosInstance = axios.create({
  baseURL: 'http://localhost:5169',
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json',
    'X-Requested-With': 'XMLHttpRequest',
    'Access-Control-Allow-Methods': 'PUT,POST,DELETE,PATCH,GET,OPTIONS',
    'Access-Control-Allow-Origin': '*',
    'Access-Control-Allow-Headers':
      'Origin, X-Requested-With, Content-Type, Accept, Authorization, Access-Control-Allow-Headers'
  }
})

// axiosInstance.interceptors.request.use(
//   function (config) {
// const token = window.localStorage.token
// if (token) {
//   config.headers.Authorization = token
// }

//     return config
//   },
//   function (error) {
//     return Promise.reject(error)
//   }
// )

export const api = {
  post (endpoint, body) {
    return axiosInstance.post(endpoint, body)
  },

  get (endpoint) {
    return axiosInstance.get(endpoint)
  },
  delete (endpoint) {
    return axiosInstance.delete(endpoint)
  }
}

export default api