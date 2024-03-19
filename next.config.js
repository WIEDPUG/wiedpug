const withNextra = require('nextra')({
    theme: 'nextra-theme-docs',
    themeConfig: './theme.config.jsx',
    staticImage: true,
    output: "export",
    basePath:"/wiedpug"
  })
   
  module.exports = withNextra()