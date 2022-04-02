#!/bin/bash

re="<div class=\"large cardpercentagebar cardpercentagebar2\">([1-9][1-9])%<\/div>"

arquivo="reportCodeCoverage/index.html"
coverage=0

while read linha; do
  if [[ $linha =~ $re ]]; then
    coverage=${BASH_REMATCH[1]}
  fi
done < $arquivo

echo $coverage
