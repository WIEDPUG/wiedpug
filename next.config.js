const withNextra = require('nextra')({
  theme: 'nextra-theme-docs',
  themeConfig: './theme.config.jsx',
  staticImage: true
})

const nextConfig = {
  images: {
    unoptimized: true,
  },
  output: "export",
  basePath: "/wiedpug"
}

module.exports = {
  ...withNextra(),
  ...nextConfig
}
