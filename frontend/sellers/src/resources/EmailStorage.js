function saveEmail (email) {
  localStorage.setItem('email', email)
}

function getEmail () {
  if (localStorage.getItem('email') !== 'undefined') {
    return localStorage.getItem('email')
  }
  return 'promoter.advantage@gmail.com'
}

module.exports = {
  saveEmail,
  getEmail
}
