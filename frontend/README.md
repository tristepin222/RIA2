
# RIA2.frontend

## Description

This project is a front end made in vue and vuetify, that works with calling API's.

## Getting Started

### Prerequisites

Make sure you have yarn installed in your computer, if not, install it https://classic.yarnpkg.com/lang/en/docs/install/#windows-stable.

#### Environment

- IDE (Visual Code studio).
- Node.js (v20.9).
- OS (windows 10, not tested under other OS).

#### Libraries

you can find the complete list in the package.json file, at the frontend folder root.

##### Prod
    "core-js": "^3.8.3",
    "cypress-file-upload": "^5.0.8",
    "vue": "^3.2.13",
    "vue-i18n": "^9.9.1",
    "vuetify": "^3.5.4"

##### Dev
    "@babel/core": "^7.12.16",
    "@babel/eslint-parser": "^7.12.16",
    "@cucumber/cucumber": "^10.3.1",
    "@vue/cli-plugin-babel": "~5.0.0",
    "@vue/cli-plugin-e2e-cypress": "~5.0.0",
    "@vue/cli-plugin-eslint": "~5.0.0",
    "@vue/cli-plugin-unit-jest": "~5.0.0",
    "@vue/cli-service": "~5.0.0",
    "@vue/test-utils": "^2.0.0-0",
    "@vue/vue3-jest": "^27.0.0-alpha.1",
    "babel-jest": "^27.0.6",
    "cypress": "^9.7.0",
    "cypress-cucumber-preprocessor": "^4.3.1",
    "eslint": "^7.32.0",
    "eslint-config-prettier": "^8.3.0",
    "eslint-plugin-prettier": "^4.0.0",
    "eslint-plugin-vue": "^8.0.3",
    "jest": "^27.0.5",
    "prettier": "^2.4.1"

### Application configuration

First, you will need to install all of the dependencies, just run `yarn install`.


## Deployment

### Dev environment

Simply run `yarn serve`.

Attention ! If the linter posses problem with CRLF and LF, just run this command `yarn lint`, it will fixes files that ends with CRLF or LF, depending which system you have (linux or windows)

### Prod environment

Simply run `yarn build`.

## Tests

The applications has two end to end tests made with cucumber BDD and cypress.
You can run them by running `yarn test:e2e`.

## Directory tree

this the architecture of the frontend project you should see, if you miss node_modules, be sure to run `yarn install`.

    frontend
    ├───doc
    ├───node_modules
    ├───public
    ├───src
        ├───assets
        ├───components
    ├───tests
        ├───e2e
            ├───plugins
            ├───specs
            ├───support
        ├───unit

## Collaborate

If you wish to collaborate, simply clone the repo, create a branch with the feature you want to fix, or add.

When you're finish with it, create a pull request, we will review your code, comment it, and it will be merged once it passes our requirements.

For more info please check the wiki.

## License

Unlicensed, Available at project root.

## Contact

If you have any problems, please reach us on github issues.
