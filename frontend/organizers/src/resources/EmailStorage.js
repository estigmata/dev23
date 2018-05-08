function saveEmail (email) {
  localStorage.setItem('email', email)
}

function getEmail () {
  if (localStorage.getItem('email') !== 'undefined') {
    return localStorage.getItem('email')
  }
}

module.exports = {
  saveEmail,
  getEmail
}
