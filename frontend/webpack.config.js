const path                = require("path");
const TsconfigPathsPlugin = require("tsconfig-paths-webpack-plugin");
const webpack             = require("webpack");
const tsNameof            = require("ts-nameof");

module.exports = {
    entry: "./src/index.tsx",
    mode: "development",

    // Enable sourcemaps for debugging webpack's output.
    devtool: "source-map",

    resolve: {
        // Add '.ts' and '.tsx' as resolvable extensions.
        alias: {
            "joi": "joi-browser",
        },
        extensions: [".js", ".tsx", ".ts"],
        plugins: [
            new TsconfigPathsPlugin({
                configFile: "./tsconfig.json",
                logLevel: "info",
            })
        ],
        symlinks: false
    },

    module: {
        rules: [
            {
                test: /\.ts(x?)$/,
                use: [
                    {
                        loader: "ts-loader",
                        options: {
                            configFile:            "tsconfig.json",
                            getCustomTransformers: () => ({ before: [tsNameof] })
                        }
                    }
                ]
            },
            // All output '.js' files will have any sourcemaps re-processed by 'source-map-loader'.
            {
                enforce: "pre",
                test: /\.js$/,
                loader: "source-map-loader"
            },
            {
                test: /\.s[ac]ss$/i,
                use: [
                    // Creates `style` nodes from JS strings
                    'style-loader',
                    // Translates CSS into CommonJS
                    'css-loader',
                    // Compiles Sass to CSS
                    'sass-loader',
                ],
            }
        ]
    },
    output: {
        path: path.resolve(__dirname, "public/"),
        publicPath: "/public/",
        filename: "bundle.js"
    },
    devServer: {
        contentBase: path.join(__dirname, "public/"),
        port: 3000,
        publicPath: "/public/",
        writeToDisk: true
    },
};
