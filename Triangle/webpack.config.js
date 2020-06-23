const path =('path');
const HtmlWebpackPlugin = require('Html-webpack-plugin');
const { CleanWebpackPlugin } = require('clean-webpack-plugin');
const UglifyJsPlugin = require('uglifyjs-webpack-plugin');
const Dotenv = require('dotenv-webpack');

module.exports = {
  entry: './src/main.js',
  output: {
    filename: 'bundle.js',
    path: path.resolve(_dirname, 'dist')
  },
devtool: 'eval-source-map',
devServer: {
  contentBase: './dist'
},
plugins: [
  new UglifyJsPlugin({ sourceMap:true}),
  new CleanWebpackPlugin(),
  new Dontenv(),
  new HtmlWebpackPlugin({
    title: 'My Project',
    template: './src/index.html',
    inject: 'body'
  })
],
module: {
  rules: [
    {
      test: /\.css$/,
      use: [
        'style-loader',
        'css-loader'
      ]
    },
    {
      test: /\.js$/,
      exclude: [
        /node_modules/,
        /spec/
      ],
      loader: "eslint-loader"
    }
  ]
}

};