# OPDCA + DMAIC Pipeline Review

## Summary

- status: failed
- project_name: NeonDrift_MVP
- chain_id: raw:NeonDrift_MVP:20260711061938
- run_id: notion-NeonDrift_MVP-dmaic-20260711071556
- source_pipeline: qa
- checks_total: 12
- checks_failed: 1
- knowledge_base: workspace/public_document/knowledge_base/game_quality/OPDCA_DMAIC_CYCLE.md

## OPDCA

- Observe: Collect completed pipeline state, generated files, Notion row metadata, QA evidence, and validation reports.
- Plan: Route to DMAIC root-cause analysis because one or more OPDCA checks failed.
- Do: Run OPDCA evidence checks and DMAIC quality analysis for source pipeline 'qa'.
- Check: 1 failed checks detected.
- Act: Create remediation row targeting qa and require concrete runtime/product evidence before passing.

## DMAIC - Define

- Problem statement: pipeline output must be detailed, playable, visually rich, evidence-backed, and traceable from raw idea to QA.
- Customer requirement: Notion must show whether planning/spec/development/build/QA evidence is sufficient before advancing.

## DMAIC - Measure

- PASS raw_idea_defined: passed
- PASS define_contract_present: passed
- PASS planning_depth_present: passed
- PASS spec_review_actionable: passed
- PASS development_unity_project_present: passed
- PASS development_runtime_probe_present: passed
- PASS build_evidence_present: passed
- PASS qa_evidence_present: passed
- PASS qa_hard_gates_present: passed
- PASS qa_runtime_evidence_artifacts_present: passed
- PASS pipeline_chain_continuity: passed
- FAIL qa_failure_signals_resolved: 1 QA failure signals require remediation

## DMAIC - Analyze

- qa_failure_signals_resolved: 1 QA failure signals require remediation

## Root Causes

- qa_failure_requires_remediation -> qa: QA report contains failed checks; the pipeline must create a remediation loop instead of closing as control monitoring.

## DMAIC - Improve

- remediation_target: qa
- Return to QA/Development loop: require simulator video, screenshots, product experience, human visual judgement, and every core gameplay function evidence.
- Create remediation Notion row targeting qa; do not stop at reporting.

## Remediation Request

DMAIC remediation target: qa

Root causes:
- qa_failure_requires_remediation: QA report contains failed checks; the pipeline must create a remediation loop instead of closing as control monitoring.

Required correction:
- Do not mark the remediation passed unless generated runtime/product evidence directly resolves the listed root causes.
- Preserve the Chain ID and source DMAIC report for traceability.
- If returning to Development, fix implementation, visual readability, gameplay playability, runtime QA probe/evidence, and retry/menu/gameplay states before Build.
- If returning to QA, rerun simulator QA and produce screenshots, video/recording evidence, raw evidence JSON, and human product-experience checks.

Observed QA failure signals:
- "expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide

## DMAIC - Control

- Keep this DMAIC row linked by Chain ID and source page.
- OPDCA Act decides whether to create remediation or close as control monitoring.
- Any future QA pass without product experience, human visual judgement, function playability, and recording evidence must remain failed.
- Any Development pass without runtime implementation evidence must be blocked before Build.

## QA Failure Signals

"expected": "QA must fail whenever the product feels unreasonable to a human: confusing gameplay, inert motion, unclear objective, unclear controls, weak visual feedback, overlapping states, placeholder visuals, missing audio/feedback evide
