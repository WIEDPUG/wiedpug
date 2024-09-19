require('dotenv').config(); // Load the .env file

const withNextra = require('nextra')({
  theme: 'nextra-theme-docs',
  themeConfig: './theme.config.jsx',
  staticImage: true
})

const isDev = process.env.ENV === 'DEV';

const nextConfig = {
  images: {
    unoptimized: true,
  },
  // Conditionally set output and basePath based on environment
  ...(isDev ? {} : {
    output: 'export',
    basePath: '/wiedpug',
  }),
}

module.exports = {
  ...withNextra(),
  ...nextConfig
}
