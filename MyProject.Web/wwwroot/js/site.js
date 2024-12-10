// Import core libraries
import 'bootstrap/dist/css/bootstrap.min.css'
import 'bootstrap/dist/js/bootstrap.bundle.min.js'
import $ from 'jquery'
import axios from 'axios'

// Import custom modules
import './modules/layout.js'
import './modules/api-handler.js'

// Global configurations
window.$ = window.jQuery = $
axios.defaults.baseURL = '/api'

// Main application logic
document.addEventListener('DOMContentLoaded', () => {
  // Initialize global components
  console.log('Application initialized')
})