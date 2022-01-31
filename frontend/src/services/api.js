import axios from 'axios'

const axiosInstance = axios.create({
  baseURL: 'http://localhost:5169',
  headers: {
    Accept: 'application/json',
    'Content-Type': 'application/json',
    'X-Requested-With': 'XMLHttpRequest'
  }
})

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
